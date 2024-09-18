namespace ObjectPool_SampleProject
{
    public class ObjectPoolService<T> where T : new()
    {
        private readonly Stack<T> _availableObjectList = new Stack<T>();

        public T GetObject()
        {
            if (_availableObjectList.Count > 0)
            {
                return _availableObjectList.Pop();
            }

            return new T(); // اگر شئی موجود نباشند، شیء جدید ایجاد میکند
        }

        public void ReleaseObject(T obj)
        {
            _availableObjectList.Push(obj); // شئی را به استک برگردان
        }
    }
}
