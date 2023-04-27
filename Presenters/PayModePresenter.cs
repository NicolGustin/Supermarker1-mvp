using System;
using System.Collections.Generic;
using System.Linq;
using System.Text,
using System.Threading.Tasks;
using Supermarker_mvp.Views;
using Supermarker_mvp.Models;

namespace Supermarker_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += AddNewPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += savePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();

        }
        private void loadAllPayModeList(object? serde, EventArgs e)
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }
        {
            throw new NotImplementedException();
        }

        private void SearchPayMode(object? serde, EventArgs e)
        {
           bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
           if (emptyValue == falce)
           {
            payModeList = repository.GetAll();
           }
           payModeBindingSource.DataSource = payModeList;
        }
        {
            throw new NotImplementedException();
        }


    private void AddNewPayMode(object? serde, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelAction(object? serde, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPayMode(object? serde, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void savePayMode(object? serde, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectPayModeToEdit(object? serde, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}


