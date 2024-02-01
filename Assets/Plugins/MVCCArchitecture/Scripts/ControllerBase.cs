namespace MVCCArchitecture
{
    public abstract class ControllerBase<TModel, TView, TController, TConfiguration>
    where TModel : ModelBase<TModel, TView, TController, TConfiguration>, new()
    where TView : ViewBase<TModel, TView, TController, TConfiguration>
    where TController : ControllerBase<TModel, TView, TController, TConfiguration>, new()
    where TConfiguration : ConfigurationBase<TModel, TView, TController, TConfiguration>
    {
        protected TModel            model;
        protected TView             view;
        protected TConfiguration    configuration;

        protected ControllerBase()
        {
            model = new TModel();
            model.SetControllerReference(this as TController);
        }

        public virtual void SetReferences(TView view, TConfiguration configuration)
        {
            this.view = view;
            if (configuration != null)
            {
                this.configuration = configuration;
                model.SetConfigurationReference(configuration);
            }
#if UNITY_EDITOR
            view.SetModelReference(model);
#endif
        }
    }
}
