using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IPayModeView
    {
        string PayModeId 
        { 
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }

        string PayModeName 
        { 
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }

        string PayModeObservation 
        { 
            get { return TxtPayModeObservation.Text;}
            set { TxtPayModeObservation.Text = value; }
        }

        public string SearchValue 
        { 
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        
        public bool IsEdit 
        { 
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        { 
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        string Message
        { 
            get { return message; }
            set { message = value; }
        }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPayModeListBildingSource(BindingSource payModeList);
        void Show();
        }
}
