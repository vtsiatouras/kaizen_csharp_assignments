namespace Assignment2;

public class PhotoBook
{
    private int _numPages;

    private const int DefaultBookPages = 16;
    
    public PhotoBook()
    {
        _numPages = DefaultBookPages;
    }

    public PhotoBook(int numPages)
    {
        _numPages = numPages;
    }

    public int GetNumberPages()
    {
        return _numPages;
    }
}
