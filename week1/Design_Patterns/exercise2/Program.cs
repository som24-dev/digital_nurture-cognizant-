using System;

// Abstract Product
public abstract class Document
{
    public abstract void Open();
}

// Concrete Products
public class WordDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening Word Document...");
    }
}

public class PdfDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening PDF Document...");
    }
}

public class ExcelDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening Excel Document...");
    }
}

// Abstract Factory
public abstract class DocumentFactory
{
    public abstract Document CreateDocument();
}

// Concrete Factories
public class WordFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new WordDocument();
    }
}

public class PdfFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new PdfDocument();
    }
}

public class ExcelFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new ExcelDocument();
    }
}

// Client Code
class Program
{
    static void Main(string[] args)
    {
        // Word
        DocumentFactory wordFactory = new WordFactory();
        Document wordDoc = wordFactory.CreateDocument();
        wordDoc.Open();

        // PDF
        DocumentFactory pdfFactory = new PdfFactory();
        Document pdfDoc = pdfFactory.CreateDocument();
        pdfDoc.Open();

        // Excel
        DocumentFactory excelFactory = new ExcelFactory();
        Document excelDoc = excelFactory.CreateDocument();
        excelDoc.Open();
    }
}
