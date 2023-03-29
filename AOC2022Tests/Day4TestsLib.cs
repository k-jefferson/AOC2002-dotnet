using AocModel;

namespace AOC2022Tests;

public class UnitTest1
{
    [Fact]
    public void Day4Tests()
    {
        var day4 = new Day4();
        Assert.Equal(305, day4.SolvePart1());

        // Part 2
        Assert.True(Day4.IntervalAIntersectsB(
            new Day4.CampSection { Start = 5, End = 7 },
            new Day4.CampSection { Start = 7, End = 9 })
        );
        Assert.True(Day4.IntervalAIntersectsB(
            new Day4.CampSection { Start = 2, End = 8 },
            new Day4.CampSection { Start = 3, End = 7 })
        );
        Assert.True(Day4.IntervalAIntersectsB(
            new Day4.CampSection { Start = 6, End = 6 },
            new Day4.CampSection { Start = 4, End = 6 })
        );
        Assert.True(Day4.IntervalAIntersectsB(
            new Day4.CampSection { Start = 2, End = 6 },
            new Day4.CampSection { Start = 4, End = 8 })
        );
        Assert.False(Day4.IntervalAIntersectsB(
            new Day4.CampSection { Start = 2, End = 4 },
            new Day4.CampSection { Start = 6, End = 8 })
        );
        Assert.False(Day4.IntervalAIntersectsB(
            new Day4.CampSection { Start = 2, End = 3 },
            new Day4.CampSection { Start = 4, End = 5 })
        );

        Assert.Equal(811, day4.SolvePart2());
    }
}
