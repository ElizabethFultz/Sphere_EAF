using System;
using System.Collections.Generic;
using System.Text;

/**
 * This class models a sphere object
 * @author Rob Kelley
 * @version 1.0
 * Lab02-Solution
 * SP19
 */

namespace Sphere_EAF
{
    class Sphere
    {

		private double diameter;

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */
		public Sphere()
		{
			diameter = 2.0;
		}//end constructor

		/**
		 * Constructor accepts value of diameter.
		 * Preferred constructor.
		 * @param diameter
		 */
		public Sphere(double diameter)
		{

			this.SetDiameter(diameter);

		}//end constructor

		/**
		 * Calculates the volume of the sphere.
		 * @return volume
		 */
		public double GetVolume()
		{

			return (4.0 / 3.0) * Math.PI * Math.Pow(diameter / 2, 3);

		}//end GetVolume

		/**
		 * Calculates the surface area of the sphere.
		 * @return - surface area
		 */
		public double GetSurfaceArea()
		{

			return 4.0 * Math.PI * Math.Pow(diameter / 2, 2);
		}//end GetSurfaceArea


		/**
		 * Getter for diameter
		 * @return
		 */
		public double GetDiameter()
		{
			return diameter;
		}//end GetDiameter

		/**
		 * Setter for diameter. Checks bound on
		 * formal parameter and resets to 2 if
		 * the value is less than 2.
		 * @param diameter
		 */
		public void SetDiameter(double diameter)
		{
			if (diameter < 2)
				this.diameter = 2;
			else
				this.diameter = diameter;
		}//end SetDiameter

		
	public override String ToString()
		{
			return "Sphere [diameter=" + diameter + "]";
		}//end toString

	}
}
