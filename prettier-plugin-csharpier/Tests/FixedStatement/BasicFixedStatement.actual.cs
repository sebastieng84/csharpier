class ClassName
{
    void MethodName()
    {
        fixed (int* p = stackalloc int[100])
        {
            *intref = 1;
        }
    }
}