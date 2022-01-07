namespace TestWars
{
    public class DirectionReductionTests
    {
        [Fact]
        public void Test1() 
        {
            var data = new[] { "NORTH", "SOUTH", "EAST", "WEST", "SOUTH", "NORTH", "WEST" };
            var actual = DirectionsReduction.dirReduc(data);
            actual.Should().BeEquivalentTo((new string[] { "WEST" }));
        }

    }
}
