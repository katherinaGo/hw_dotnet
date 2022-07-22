namespace HW._11.Task1;

public abstract class BaseEntity
{
    private Guid _id;

    protected virtual internal Guid Id
    {
        get => _id;
        set => _id = value;
    }
}