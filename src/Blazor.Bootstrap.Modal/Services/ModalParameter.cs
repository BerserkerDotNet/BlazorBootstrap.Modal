namespace Blazor.Bootstrap.Modal.Services
{
    public class ModalParameter
    {
        private ModalParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }

        public object Value { get; private set; }

        public static ModalParameter Get(string name, object value)
        {
            return new ModalParameter(name, value);
        }
    }
}
