using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.AssetLibrary.ViewModels {

    public class ResultViewModel<TViewModel> : ResultViewModel, Framework.ITypedResult {

        public ResultViewModel( ) {

        }

        public ResultViewModel( bool isSuccess, String message, TViewModel returnValue )
            : base( isSuccess, message ) {
            this.ReturnValue = returnValue;
        }


        private TViewModel _ReturnValue = default( TViewModel );

        public TViewModel ReturnValue {
            get {
                return _ReturnValue;
            }

            set {
                this._ReturnValue = value;
            }
        }

        Object Framework.ITypedResult.ReturnValue {
            get { return this.ReturnValue; }
        }
    }

}
