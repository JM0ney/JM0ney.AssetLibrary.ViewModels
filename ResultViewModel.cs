using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.AssetLibrary.ViewModels {

    /// <summary>
    /// Represents the result of some action being performed
    /// </summary>
    public class ResultViewModel : Framework.IResult {

        public ResultViewModel( ) {
        }

        public ResultViewModel( bool isSuccess, String message ) {
            this.IsSuccess = isSuccess;
            this.Message = message;
        }

        private bool _IsSuccess = false;
        private String _Message = String.Empty;

        public Boolean IsSuccess {
            get {
                return _IsSuccess;
            }
            private set {
                this._IsSuccess = value;
            }
        }

        public String Message {
            get {
                return _Message;
            }
            private set {
                this._Message = value;
            }
        }
    }

}
