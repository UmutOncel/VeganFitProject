namespace VeganFit.Shared
{
    public class ResultService<T> where T : class
    {
        private List<ErrorItem> _errors;
        public IEnumerable<ErrorItem> Errors => _errors;
        public bool HasError => Errors.Any();
        public T Data { get; set; }

        public ResultService()
        {
            _errors = new List<ErrorItem>();
        }

        /// <summary>
        /// Hata listesine hata tipini ve mesajını ekleyen metot. 
        /// </summary>
        /// <param name="errorType"></param>
        /// <param name="errorMessage"></param>
        public void AddError(ErrorType errorType, string errorMessage) 
        {
            _errors.Add(new ErrorItem
            {
                ErrorType = errorType,
                ErrorMessage = errorMessage
            });
        }
    }
}
