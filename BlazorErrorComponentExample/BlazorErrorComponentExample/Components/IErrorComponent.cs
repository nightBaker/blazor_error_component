namespace BlazorErrorComponentExample.Components
{
    public interface IErrorComponent
    {
        void ShowError(string title, string message);
    }
}