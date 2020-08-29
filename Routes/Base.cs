namespace Enhanced_API {
    public class BaseRoutes : Nancy.NancyModule {
        public BaseRoutes() {
            Get("/", _ => "Received GET request");

            Post("/", _ => "Received POST request");
        }
    }
}
