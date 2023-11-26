
namespace Prototype
{
    internal interface IPrototype<T>
    {
        T ShallowClone();
        T DeepClone();
    }
}
