using System;
using System.ServiceModel;
using System.ComponentModel;
using System.Threading;
using WcfDuplexServiceInterface;
using System.Windows.Forms;

namespace WcfDuplexServiceClient
{

    /* UseSynchronizationContext:
     * For a Windows Forms application such as our client this behavior would 
     * result in the code being run on the user interface thread (default true). 
     * By setting UseSynchronizationContext to false the callback operations will 
     * instead be entrusted to worker threads. */

    [CallbackBehavior(UseSynchronizationContext = false)]
    class WcfDuplexCallBack : IDuplexCallBack
    {
        private SynchronizationContext _syncContext = AsyncOperationManager.SynchronizationContext;
        public event EventHandler<UpdatedListEventArgs> ServiceCallbackEvent;

        public void broadcastUpdate(string msg,string caption)
        {
            // Post => dispatches an asynchronous (asynchronous = can move on to another task before it finishes) 
            //         message to a synchronization context.

            // SendOrPostCallback => Represents a method to be called when a message is to be dispatched to a synchronization context.          
            _syncContext.Post(new SendOrPostCallback(broadcastUpdateMsgBox), new updateMsg(msg,caption));
        }

        private void broadcastUpdateMsgBox(object state)
        {
            updateMsg message = state as updateMsg;
            MessageBox.Show(message.Msg, message.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    class updateMsg
    {
        private string _msg;
        private string _caption;

        public string Msg
        {
            get { return _msg; }
            set { _msg = value; }
        }

        public string Caption
        {
            get { return _caption; }
            set { _caption = value; }
        }

        public updateMsg(string msg,string caption)
        {
            _msg = msg;
            _caption = caption;
        }
    }

}
