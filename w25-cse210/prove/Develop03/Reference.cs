public class Reference
{

    //Attributes

    private string _book;
    private int _chapter;
    private int _fverse;
    private int _lverse;


    //Initialize
    public Reference(string book, int chapter, int fverse)
    {
        this._book = book;
        this._chapter = chapter;
        this._fverse = fverse;
        this._lverse = -1;
    }

    public Reference(string book, int chapter, int fverse, int lverse)
    {
        this._book = book;
        this._chapter = chapter;
        this._fverse = fverse;
        this._lverse = lverse;
    }

    //Behaviors

    public string DisplayReference()
    {
        if (_lverse == -1)
        {
            return $"{_book} {_chapter}: {_fverse}";
        }

        else
        {
            return $"{_book} {_chapter}: {_fverse}-{_lverse}";
        }
    }
}