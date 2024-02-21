public interface IDataDownloader<Tkey, TData>
{
    TData Download(Tkey key);
}