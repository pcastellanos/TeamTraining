namespace SOLID.InterfaceSegregation
{
    /// <summary>
    /// Interface to define the method of transportation
    /// </summary>
    public interface IConveyance
    {
        /// <summary>
        /// Moves vehicle from one point to another
        /// </summary>
        /// <param name="from">Point to start moving</param>
        /// <param name="to">Final point to move</param>
        void Move(Point from, Point to);

        /// <summary>
        /// Way to change the wheels to a vehicle
        /// </summary>
        void ChangeWheels();
    }
}

