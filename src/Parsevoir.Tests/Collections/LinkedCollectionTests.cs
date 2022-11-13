using FluentAssertions;
using Parsevoir.Collections;

namespace Parsevoir.Tests.Collections;

public class LinkedCollectionTests
{
    private static readonly (string val1, string val2, string val3, string val4, string val5) Values = ("1", "2", "3", "4", "5");
    
    [Fact]
    public void Ctor_Success()
    {
        LinkedCollection<string>? collection = null;

        var act = () => collection = new LinkedCollection<string>();

        act.Should().NotThrow();
        collection.Should().NotBeNull();
    }

    [Fact]
    public void AddValues_Success()
    {
        var collection = new LinkedCollection<string>();

        collection.Count.Should().Be(0);
        
        collection.Add(Values.val1);
        collection.Add(Values.val2);
        collection.Add(Values.val3);
        
        collection.Count.Should().Be(3);
    }

    [Fact]
    public void ToArray_Success()
    {
        var collection = new LinkedCollection<string>();
        
        collection.Add(Values.val1);
        collection.Add(Values.val2);
        collection.Add(Values.val3);

        string[] array = collection.ToArray();

        array.Should().HaveCount(3);
        array.Should().Contain(Values.val1);
        array.Should().Contain(Values.val2);
        array.Should().Contain(Values.val3);
        
        collection.Add(Values.val4);
        collection.Add(Values.val5);
        
        array.Should().NotContain(Values.val4);
        array.Should().NotContain(Values.val5);
        
        array = collection.ToArray();
        
        array.Should().Contain(Values.val4);
        array.Should().Contain(Values.val5);
    }

    [Fact]
    public void Clear_Success()
    {
        var collection = new LinkedCollection<string>();

        collection.Count.Should().Be(0);
        
        collection.Add(Values.val1);
        collection.Add(Values.val2);
        collection.Add(Values.val3);
        
        collection.Count.Should().Be(3);
        
        collection.Clear();
        
        collection.Count.Should().Be(0);
        
        collection.Add(Values.val1);
        collection.Add(Values.val2);
        
        collection.Count.Should().Be(2);
    }

    [Fact]
    public void ToEmptyArray_Success()
    {
        var collection = new LinkedCollection<string>();
        
        string[]? array = null;
        
        var act = () => array = collection.ToArray();

        act.Should().NotThrow();
        array.Should().NotBeNull();
        array.Should().BeEmpty();
    }
}