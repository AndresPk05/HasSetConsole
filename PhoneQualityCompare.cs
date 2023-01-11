using System.Diagnostics.CodeAnalysis;

namespace HasSetConsole
{
    public class PhoneQualityCompare : IEqualityComparer<Phone>
    {
        public bool Equals(Phone? x, Phone? y)
        {
            if (x is null && y is null)
                return true;

            if(x is null || y is null)
                return false;

            return x.Id.Equals(y.Id);
        }

        public int GetHashCode([DisallowNull] Phone obj)
        {
            return obj.Id.GetHashCode();    
        }
    }
}
