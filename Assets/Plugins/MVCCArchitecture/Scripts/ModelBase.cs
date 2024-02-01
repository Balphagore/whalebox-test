namespace MVCCArchitecture
{
    public abstract class ModelBase<TModel, TView, TController, TConfiguration>
    where TModel : ModelBase<TModel, TView, TController, TConfiguration>, new()
    where TView : ViewBase<TModel, TView, TController, TConfiguration>
    where TController : ControllerBase<TModel, TView, TController, TConfiguration>, new()
    where TConfiguration : ConfigurationBase<TModel, TView, TController, TConfiguration>
    {
        protected TController       controller;
        protected TConfiguration    configuration;

        public virtual void SetControllerReference(TController controller)
        {
            this.controller = controller;
        }

        public virtual void SetConfigurationReference(TConfiguration configuration)
        {
            this.configuration = configuration;
        }
    }
}
