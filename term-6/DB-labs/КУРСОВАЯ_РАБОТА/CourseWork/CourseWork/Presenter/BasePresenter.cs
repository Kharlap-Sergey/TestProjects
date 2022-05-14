using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SweetShop.Models.Entities;

namespace CourseWork.Presenter
{
    public partial class BasePresenter<PresentationModel> : UserControl
    {
        protected readonly Action<PresentationModel, Action<PresentationModel>> _editHandle;
        public PresentationModel Model { get; set; }

        public BasePresenter()
        {
            InitializeComponent();
        }

        public BasePresenter(
            PresentationModel category,
            Action<PresentationModel, Action<PresentationModel>> editHandle
        )
            : this()
        {
            _editHandle = editHandle;
            Model = category;
        }

        //protected abstract void UpdatePresenter(PresentationModel model);
    }
}
