namespace MVCCArchitecture
{
    using UnityEngine;

    public class ConfigurationBase<TModel, TView, TController, TConfiguration> : ScriptableObject
        where TModel : ModelBase<TModel, TView, TController, TConfiguration>, new()
        where TView : ViewBase<TModel, TView, TController, TConfiguration>
        where TController : ControllerBase<TModel, TView, TController, TConfiguration>, new()
        where TConfiguration : ConfigurationBase<TModel, TView, TController, TConfiguration>
    {

    }
}
