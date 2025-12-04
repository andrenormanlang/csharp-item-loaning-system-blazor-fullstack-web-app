namespace A6_ComicBooksExchangeApp.Services
{
    /// <summary>
    /// Service that manages and broadcasts authentication state changes.
    /// Components can subscribe to OnAuthStateChanged to react to login/logout events.
    /// </summary>
    public class AuthStateProvider
    {
        /// <summary>
        /// Event fired when authentication state changes (login or logout).
        /// </summary>
        public event Action? OnAuthStateChanged;

        /// <summary>
        /// Gets whether the user is currently authenticated.
        /// </summary>
        public bool IsAuthenticated { get; private set; }

        /// <summary>
        /// Gets the current username if authenticated.
        /// </summary>
        public string CurrentUsername { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the current user ID if authenticated.
        /// </summary>
        public int CurrentUserId { get; private set; }

        /// <summary>
        /// Notifies subscribers that the user has logged in.
        /// </summary>
        public void NotifyLogin(int userId, string username)
        {
            IsAuthenticated = true;
            CurrentUserId = userId;
            CurrentUsername = username;
            OnAuthStateChanged?.Invoke();
        }

        /// <summary>
        /// Notifies subscribers that the user has logged out.
        /// </summary>
        public void NotifyLogout()
        {
            IsAuthenticated = false;
            CurrentUserId = 0;
            CurrentUsername = string.Empty;
            OnAuthStateChanged?.Invoke();
        }

        /// <summary>
        /// Sets the initial auth state (called during app initialization).
        /// </summary>
        public void SetInitialState(bool isAuthenticated, int userId = 0, string username = "")
        {
            IsAuthenticated = isAuthenticated;
            CurrentUserId = userId;
            CurrentUsername = username;
            // Don't trigger event for initial state - components will read directly
        }
    }
}
