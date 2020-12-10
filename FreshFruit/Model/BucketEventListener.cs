using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruit.Model
{
    class BucketEventListener
    {
        void on5ucceed(string message);
        void onFailed(string message);

        internal void onFailed(string v)
        {
            throw new NotImplementedException();
        }

        internal void onSucceed(string v)
        {
            throw new NotImplementedException();
        }
    }
}
