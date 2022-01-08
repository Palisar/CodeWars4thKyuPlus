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
         [Fact]
         public void Test2()
        {
            var data = new[] { "NORTH", "WEST", "SOUTH", "EAST" };
            var actual = DirectionsReduction.dirReduc(data);
            actual.Should().BeEquivalentTo(new[] { "NORTH", "WEST", "SOUTH", "EAST" });
        }
    }
}
