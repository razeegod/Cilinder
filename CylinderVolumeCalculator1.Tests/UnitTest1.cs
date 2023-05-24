using System;
using Xunit;
using CylinderVolumeCalculator1;

namespace CylinderVolumeCalculator1.Tests
{
    public class UnitTest1
    {
        public class CylinderVolumeCalculatorTests
        {
            [Theory]
            [InlineData(3, 4, 113.09733552923254)]
            [InlineData(5, 5, 392.69908169872417)]
            public void CalculateCylinderVolume_PositiveRadiusAndHeight_ReturnsCorrectVolume(double radius, double height, double expectedVolume)
            {
                double actualVolume = Program.CalculateCylinderVolume(radius, height);

                Assert.Equal(expectedVolume, actualVolume, 5);
            }

            [Theory]
            
            [InlineData(3, -4)]
            [InlineData(-3, -4)]
            public void CalculateCylinderVolume_NegativeRadiusOrHeight_ThrowsArgumentException(double radius, double height)
            {
                Assert.Throws<System.ArgumentException>(() => Program.CalculateCylinderVolume(radius, height));
            }
        }
    }
}