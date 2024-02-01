namespace MVCCArchitecture
{
    using UnityEngine;
    using Zenject;

    public abstract class ViewBase<TModel, TView, TController, TConfiguration> : MonoBehaviour
        where TModel : ModelBase<TModel, TView, TController, TConfiguration>, new()
        where TView : ViewBase<TModel, TView, TController, TConfiguration>
        where TController : ControllerBase<TModel, TView, TController, TConfiguration>, new()
        where TConfiguration : ConfigurationBase<TModel, TView, TController, TConfiguration>
    {
        [Inject]
        protected TController       controller;
        [SerializeField]
        protected TConfiguration    configuration;
        [SerializeField, ReadOnly]
        protected TModel            model;

        protected virtual void Awake()
        {
            controller.SetReferences(this as TView, configuration);
        }

#if UNITY_EDITOR
        public virtual void SetModelReference(TModel model)
        {
            this.model = model;
        }
#endif
    }
}
