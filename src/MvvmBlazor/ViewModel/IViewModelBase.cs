using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MvvmBlazor.ViewModel
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        void RaisePropertyChanged(string propertyName);
        void OnAfterRender(bool firstRender);
        Task OnAfterRenderAsync(bool firstRender);
        void OnInitialized();
        Task OnInitializedAsync();
        void OnParametersSet();
        Task OnParametersSetAsync();
        Task SetParametersAsync(ParameterView parameters);
        bool ShouldRender();
    }
}