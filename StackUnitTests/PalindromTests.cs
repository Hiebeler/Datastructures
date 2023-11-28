using Common;
using NUnit.Framework;

namespace DatastructurTests;

public class PalindromTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Palindrom_GiveANNABy_ReturnsTrue()
    {
        Assert.IsTrue(Palindrom.IsPalindrom("ANNA"));
    }
    
    [Test]
    public void Palindrom_GiveOTTOBy_ReturnsTrue()
    {
        Assert.IsTrue(Palindrom.IsPalindrom("OTTO"));
    }
    
    [Test]
    public void Palindrom_GivelagerregalByLowerCase_ReturnsTrue()
    {
        Assert.IsTrue(Palindrom.IsPalindrom("lagerregal"));
    }
    
    [Test]
    public void Palindrom_PalindromWithNumbers_WorksTo()
    {
        Assert.IsTrue(Palindrom.IsPalindrom("A9119A"));
    }
    
    [Test]
    public void Palindrom_GiveEmptyString_ReturnsTrue()
    {
        Assert.IsTrue(Palindrom.IsPalindrom(""));
    }
    
    [Test]
    public void Palindrom_SpecialCharacters_ReturnsTrue()
    {
        Assert.IsTrue(Palindrom.IsPalindrom("&§$$§&"));
    }
    
    [Test]
    public void Palindrom_TryWithOddCount_ReturnsTrue()
    {
        Assert.IsTrue(Palindrom.IsPalindrom("AN2NA"));
    }
    
    [Test]
    public void Palindrom_WrongCase_ReturnsFalse()
    {
        Assert.IsFalse(Palindrom.IsPalindrom("OtTo"));
    }
}