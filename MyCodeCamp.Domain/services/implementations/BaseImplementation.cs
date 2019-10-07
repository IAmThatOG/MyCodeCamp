namespace MyCodeCamp.Domain.services.implementations
{
    public class BaseImplementation<T>
    {
        protected T _repo;
        public BaseImplementation(T repo)
        {
            _repo = repo;
        }
    }
}