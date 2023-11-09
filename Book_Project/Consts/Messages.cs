namespace Book_Project.Consts;

public class Messages
{
    public static string BookTitleExceptionMessage(string title)
    {
        return $"{title}, minimum 2 karakterli olmalidir. girdiginiz karakter sayisi : {title.Length}";
    }

    public static string BookPriceAndStockExceptionMessage(double price , int stock)
    {
        return $"girdiginiz stok ve deger bilgisi negatif degerler olamaz! Stock : {stock}, Deger : {price}";
    }
    public static string AuthorNameException(string authorName)
    {
        return $"yazar adi en az 2 karakterli olmalidir! : {authorName}";
    }
    public static string BookNotFoundWithIsbnMessage(string isbn)
    {
        return $"isbn bulunamadi {isbn}";
    }
}
