namespace Lab3_02.Interface
{
    public interface IConnectable
    {
        void Connect(Computer device);
        void Disconnect(Computer device);
        void TransferData(Computer source, Computer destination, string data);

    }
}