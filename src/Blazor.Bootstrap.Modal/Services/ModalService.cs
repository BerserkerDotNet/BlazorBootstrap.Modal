using System;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace Blazor.Bootstrap.Modal.Services
{
    public class ModalService : IModal
    {
        public event Action<string, RenderFragment> OnShow;

        public event Action OnClose;

        public void Show<T>(string title, params ModalParameter[] parameters)
            where T : ComponentBase
        {
            var content = new RenderFragment(x =>
            {
                var idx = 1;
                x.OpenComponent(idx++, typeof(T));
                if (parameters != null && parameters.Any())
                {
                    foreach (var parameter in parameters)
                    {
                        x.AddAttribute(idx++, parameter.Name, parameter.Value);
                    }
                }

                x.CloseComponent();
            });

            OnShow?.Invoke(title, content);
        }

        public void Close()
        {
            OnClose?.Invoke();
        }
    }
}
