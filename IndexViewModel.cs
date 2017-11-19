//
//  Do you like this project? Do you find it helpful? Pay it forward by hiring me as a consultant!
//  https://jason-iverson.com
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.AssetLibrary.ViewModels {

    public class IndexViewModel<TViewModel> : List<TViewModel>
        where TViewModel : Base.ViewModelBase, new() 
    {

        #region Fields

        private Guid? _ParentIdentity = null;
        private bool _ForDisplayOnly = false;

        #endregion Fields

        #region Cosntructor(s)

        public IndexViewModel( bool forDisplayOnly, Guid? parentIdentity, IEnumerable<TViewModel> items ) {
            this.ParentIdentity = parentIdentity;
            this.ForDisplayOnly = ForDisplayOnly;
            if ( items != null && items.Any() )
                this.AddRange( items );
        }

        public IndexViewModel( Guid? parentIdentity, IEnumerable<TViewModel> items ) 
            : this( false, parentIdentity, items )
            { }


        #endregion Constructor(s)

        #region Properties

        public Guid? ParentIdentity {
            get {
                return _ParentIdentity;
            }

            set {
                this._ParentIdentity = value;
            }
        }

        public Boolean ForDisplayOnly {
            get {
                return _ForDisplayOnly;
            }

            set {
                this._ForDisplayOnly = value;
            }
        }

        #endregion Properties
    }

}
