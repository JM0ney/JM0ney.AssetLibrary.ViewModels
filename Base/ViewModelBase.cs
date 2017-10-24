//
//	Do you like this project? Do you find it helpful? Pay it forward by hiring me as a consultant!
//  https://jason-iverson.com
//
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JM0ney.Framework.Data;

namespace JM0ney.AssetLibrary.ViewModels.Base {

    public abstract class ViewModelBase {

        #region Fields

        private Guid _Identity = Guid.NewGuid( );
        private EditorModes _EditorMode = EditorModes.Indeterminate;

        #endregion Fields

        #region Properties

        public Guid Identity {
            get { return this._Identity; }
            set { this._Identity = value; }
        }

        public EditorModes EditorMode {
            get { return this._EditorMode; }
            set { this._EditorMode = value; }
        }

        #endregion Properties

        public virtual void Load( int tableIndex, int rowIndex, String fieldNamePrefix, DataSet dataSet ) {
            this.Identity = dataSet.GetValue<Guid>( tableIndex, rowIndex, "Identity", fieldNamePrefix );
        }

    }

}
