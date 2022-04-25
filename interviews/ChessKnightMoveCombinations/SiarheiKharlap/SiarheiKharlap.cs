using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SiarheiKharlap
{
    public static class SiarheiKharlap
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var res = SiarheiKharlap.SolveMatrix();
            sw.Stop();
            Console.WriteLine($"required time in ms - {sw.ElapsedMilliseconds}");
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static char[,] Matrix { get; set; } =
        {
            { 'A', 'B', 'C', ' ', 'E' },
            { ' ', 'G', 'H', 'I', 'J' },
            { 'K', 'L', 'M', 'N', 'O' },
            { 'P', 'Q', 'R', 'S', 'T' },
            { 'U', 'V', ' ', ' ', 'Y' }
        };

        public static int N { get; set; } = 5;
        public static int PathLengthConstraint { get; set; } = 8;
        public static char[] ConstrainedElements { get; set; } = { 'A', 'Y', 'E', 'I', 'O', 'U' };
        public static int ConstrainedElementsMaxAmount { get; set; } = 10;

        public static IChessKnightStrategy _strategy = new DynamicChessKnightStrategy();
        public static long SolveMatrix()
        {
            long unicPathesAmount = _strategy.Execute(
                Matrix,
                N,
                PathLengthConstraint,
                ConstrainedElements,
                ConstrainedElementsMaxAmount
            );

            return unicPathesAmount;
        }
    }

    public interface IChessKnightStrategy
    {
        long Execute(
            char[,] matrix,
            int n,
            int pathLengthConstraint,
            char[] constrainedElements,
            int constrainedElementsMaxAmount
        );
    }

    public class RecursionChessKnightStrategy : IChessKnightStrategy
    {
        private char[,] _matrix;
        private int _n;
        private int _pathLengthConstraint;
        private HashSet<char> _constrainedElements;
        private int _constrainedElementsMaxAmount;

        private List<(int, int)> _steps = new List<(int, int)>
        {
            (1, 2),
            (1, -2),
            (-1, 2),
            (-1, -2),
            (2, 1),
            (-2, 1),
            (2, -1),
            (-2, -1)
        };

        public long Execute(
            char[,] matrix,
            int n,
            int pathLengthConstraint,
            char[] constrainedElements,
            int constrainedElementsMaxAmount)
        {
            _matrix = matrix;
            _n = n;
            _pathLengthConstraint = pathLengthConstraint;
            _constrainedElements = constrainedElements.ToHashSet();
            _constrainedElementsMaxAmount = constrainedElementsMaxAmount;

            long res = 0;
            for (var i = 0; i < _n; i++)
            for (var j = 0; j < _n; j++)
                    res += MakeStep((i, j), 0, 0);
            return res;
        }

        private long MakeStep(
            (int, int) cell,
            int currentLength,
            int usedConstrains
        )
        {
            if (cell.Item1 < 0 || cell.Item2 < 0 || cell.Item1 >= _n || cell.Item2 >= _n)
                return 0;

            char cellValue;
            try
            {
                cellValue = _matrix[cell.Item1, cell.Item2];
            }
            catch
            {
                return 0;
            }

            if (!IsCellAvailable(cellValue))
                return 0;

            if (IsConstraint(cellValue))
                usedConstrains += 1;

            if (usedConstrains > _constrainedElementsMaxAmount)
                return 0;

            currentLength++;
            if (currentLength == _pathLengthConstraint)
                return 1;

            long res = 0;
            foreach ((int, int) step in _steps)
            {
                (int, int) cellToGo = (cell.Item1 + step.Item1, cell.Item2 + step.Item2);
                res += MakeStep(cellToGo, currentLength, usedConstrains);
            }

            return res;
        }

        private bool IsConstraint(char cellValue)
        {
            return _constrainedElements.Contains(cellValue);
        }

        private bool IsCellAvailable(char cellValue)
        {
            return cellValue != ' ';
        }
    }

    public class DynamicChessKnightStrategy : IChessKnightStrategy
    {
        private char[,] _matrix;
        private int _n;
        private int _pathLengthConstraint;
        private HashSet<char> _constrainedElements;
        private int _constrainedElementsMaxAmount;


        private List<(int, int)> _steps = new List<(int, int)>
        {
            (1, 2),
            (1, -2),
            (-1, 2),
            (-1, -2),
            (2, 1),
            (-2, 1),
            (2, -1),
            (-2, -1)
        };

        private long[,,,] _dinamic;

        public long Execute(
            char[,] matrix,
            int n,
            int pathLengthConstraint,
            char[] constrainedElements,
            int constrainedElementsMaxAmount)
        {

            _matrix = matrix;
            _n = n;
            _pathLengthConstraint = pathLengthConstraint;
            _constrainedElements = constrainedElements.ToHashSet();
            _constrainedElementsMaxAmount = constrainedElementsMaxAmount;

            _dinamic = new long[n, n, pathLengthConstraint, constrainedElementsMaxAmount + 1];

            int constrainsLen = Math.Min(constrainedElementsMaxAmount, pathLengthConstraint);
            for (var i = 0; i < n; i++)
            for (var j = 0; j < n; j++)
            for (var indexFromEnd = 0; indexFromEnd < pathLengthConstraint; indexFromEnd++)
            for (var usedConstrains = 0; usedConstrains <= constrainsLen; usedConstrains++)
                _dinamic[i, j, indexFromEnd, usedConstrains] = 0;

            return Solve();
        }

        private long Solve()
        {
            int constrainsLen = Math.Min(_constrainedElementsMaxAmount, _pathLengthConstraint);
            var cellValue = ' ';
            for (var indexFromEnd = 0; indexFromEnd < _pathLengthConstraint; indexFromEnd++)
            for (var i = 0; i < _n; i++)
            for (var j = 0; j < _n; j++)
            {
                if (!TryGetValue((i, j), ref cellValue))
                    continue;
                if (!IsCellAvailable(cellValue))
                    continue;

                int isConstraint = IsConstraint(cellValue) ? 1 : 0;

                if (indexFromEnd == 0)
                {
                    _dinamic[i, j, indexFromEnd, isConstraint] = 1;
                    continue;
                }

                for (var usedConstrains = 0; usedConstrains <= constrainsLen; usedConstrains++)
                {
                    int takeConstraint = usedConstrains - isConstraint;
                    if (takeConstraint < 0)
                        continue;

                    foreach ((int, int) step in _steps)
                    {
                        if (!TryGetValue((i + step.Item1, j + step.Item2), ref cellValue))
                            continue;

                        long pathes = _dinamic[i + step.Item1, j + step.Item2, indexFromEnd - 1, takeConstraint];
                        _dinamic[i, j, indexFromEnd, usedConstrains] += pathes;
                    }
                }
            }

            long res = 0;
            for(var i = 0; i < _n; i++)
            for(var j = 0; j < _n; j++)
            for (var u = 0; u <= _constrainedElementsMaxAmount; u++)
                res += _dinamic[i, j, _pathLengthConstraint - 1, u];

            return res;
        }
        private bool TryGetValue((int, int) cell, ref char result)
        {
            try
            {
                if (cell.Item1 < 0 || cell.Item2 < 0 || cell.Item1 >= _n || cell.Item2 >= _n)
                    return false;

                result = _matrix[cell.Item1, cell.Item2];
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool IsConstraint(char cellValue)
        {
            return _constrainedElements.Contains(cellValue);
        }

        private bool IsCellAvailable(char cellValue)
        {
            return cellValue != ' ';
        }
    }
}