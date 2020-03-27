namespace Warehouse_library
{
    // Global delegate fields.
    public delegate void MessageHandler(string str);
    public delegate string InputHandler();


    public static class DelegateHolder
    {
        public static MessageHandler showMessage;
        public static InputHandler readString;


        public static void SetShowMessageHandler(MessageHandler del)
        {
            showMessage = del;
        }
        public static void SetInputHandler(InputHandler del)
        {
            readString = del;
        }
    }
}
