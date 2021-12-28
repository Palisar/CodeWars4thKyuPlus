using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWars
{
    public class SatNavTests
    {
        [Fact]
        public void Test()
        {
            var directions = new[]
            {
            "Head EAST",
            "Take the 2nd LEFT",
            "Take the NEXT LEFT",
            "Take the NEXT LEFT",
            "Go straight on for 1.5km",
            "Take the NEXT RIGHT",
            "Take the 2nd RIGHT",
            "Go straight on for 1.7km",
            "Turn around!",
            "Take the NEXT LEFT",
            "Go straight on for 1.0km",
            "You have reached your destination!"
        };
            var actual = SatNavOS.SatNav(directions);
            actual.Should().Be(new Point() { y = 0, x = 0 });
        }

        [Fact]
        public void Ex2()
        {
            var directions = new[]
            {
            "Head NORTH",
            "Take the 2nd LEFT",
            "Take the 2nd LEFT",
            "Take the NEXT LEFT",
            "Go straight on for 3.5km",
            "Take the NEXT RIGHT",
            "Go straight on for 2.3km",
            "Take the NEXT RIGHT",
            "Take the NEXT RIGHT",
            "Take the NEXT LEFT",
            "Take the NEXT RIGHT",
            "Go straight on for 900m",
            "You have reached your destination!"
        };
            var actual = SatNavOS.SatNav(directions);
            actual.Should().Be(new Point() { y = -1, x = 0 });
        }

        [Fact]
        public void TestCompassLEFT()
        {
            var data = "LEFT";
            var actual = SatNavOS.SetCompass(data, Compass.NORTH);
            actual.Should().Be(Compass.WEST);
        }

        [Fact]
        public void TestCompassRIGHT()
        {
            var data = "RIGHT";
            var actual = SatNavOS.SetCompass(data, Compass.NORTH);
            actual.Should().Be(Compass.EAST);
        }

        [Fact]
        public void Attempt1()
        {
            var data = new[]
            {
                "Head WEST",
                "Go straight on for 4.0km",
                "Turn around!",
                "Take the 2nd LEFT",
                "You have reached your destination"
            };
            var actual = SatNavOS.SatNav(data);
            actual.Should().Be(new Point() { x = -20, y = 0 });
        }

        [Fact]
        public void GoingStraight()
        {
            var directions = new[]
            {
            "Head NORTH",
            "Go straight on for 1.7km",
            "Turn around!",
            "Go straight on for 1.7km",
            "You have reached your destination!"
        };
            var actual = SatNavOS.SatNav(directions);
            actual.Should().Be(new Point() { y = 0, x = 0 });
        }

        [Fact]
        public void TurningAround()
        {
            var directions = new[]
            {
            "Head NORTH",
            "Go straight on for 1.7km",
            "Turn around!",
            "Take the 2nd LEFT",
            "You have reached your destination!"
        };
            var actual = SatNavOS.SatNav(directions);
            actual.Should().Be(new Point() { y = 0, x = 0 });
        }

        [Fact]
        public void FromNegXToPosEven()
        {
            var directions = new[]
            {
                "Head WEST",
                "Go straight on for 2.8km",
                "Turn around!",
                "Take the 4th LEFT",
                "You have reached your destination!"
            };
            var actual = SatNavOS.SatNav(directions);
            actual.Should().Be(new Point() { x=10, y=0 });
        }

        [Fact] 
        public void ZedBug()
        {
            var directions = new[]
            {
                "Head NORTH",
                "Take the 3rd RIGHT",
                "Go straight on for 700m",
                "Turn around!",
                "Go straight on for 400m",
                "Take the 3rd LEFT",
                "Go straight on for 700m",
                "Take the 2nd LEFT",
                "Take the 5th RIGHT",
                "Go straight on for 4.4km",
                "Turn around!",
                "You have reached your destination!"
            };
            var actual = SatNavOS.SatNav(directions);
            actual.Should().Be(new Point() { x = 30, y = -34 });
        }
    }
}
