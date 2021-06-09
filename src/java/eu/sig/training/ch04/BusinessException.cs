public class BusinessException : Exception {
    private static readonly long serialVersionUID = 1L;

    public BusinessException(String message) {
        super(message);
    }
}