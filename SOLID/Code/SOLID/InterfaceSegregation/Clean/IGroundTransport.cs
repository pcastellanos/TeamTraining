namespace SOLID.InterfaceSegregation.Clean
{
    /// <summary>
    /// Interface to define behaviours with a ground transport
    /// </summary>
    public interface IGroundTransport
    {
        /// <summary>
        /// Way to change the wheels to a vehicle
        /// </summary>
        void ChangeWheels();
    }
}
