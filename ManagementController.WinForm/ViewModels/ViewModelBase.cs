using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ManagementController.WinForm.ViewModels
{
    /// <summary>
    /// ViewModelの基底クラス
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// イベントハンドラ
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // MVVM Rism BidableBaseを参考に
        protected bool SetProperty<T>(ref T field,
            T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            var h = this.PropertyChanged;
            if (h != null)
            {
                h(this, new PropertyChangedEventArgs(propertyName));
            }
            return true;
        }
    }
}
