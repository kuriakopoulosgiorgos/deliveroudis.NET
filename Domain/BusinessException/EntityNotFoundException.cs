namespace Domain.BusinessException;

public class EntityNotFoundException(string message) : Exception(message);
