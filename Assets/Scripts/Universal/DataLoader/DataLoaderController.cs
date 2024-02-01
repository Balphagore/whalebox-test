namespace WhaleBoxTest.Universal.DataLoader
{
    using System;

    using Zenject;
    using MVCCArchitecture;

    public class DataLoaderController : ControllerBase<DataLoaderModel, DataLoaderView, DataLoaderController, DataLoaderConfiguration>,
        IInitializable
    {
        public Action<GameDataModel> DataLoadedEvent;

        public void Initialize()
        {
            model.LoadData();
            DataLoadedEvent?.Invoke(model.GetLoadedData());
        }

        public void UpdateRecord(int newRecord)
        {
            model.UpdateRecord(newRecord);
        }

        public void UpdateSoundValue(bool isDisabled)
        {
            model.UpdateSoundValue(isDisabled);
        }
    }
}
