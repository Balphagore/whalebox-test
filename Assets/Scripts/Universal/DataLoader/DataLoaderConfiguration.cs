namespace WhaleBoxTest.Universal.DataLoader
{
    using UnityEngine;

    using MVCCArchitecture;

    [CreateAssetMenu(fileName = "DataLoaderConfiguration", menuName = "Data/Configurations/DataLoaderConfiguration")]
    public class DataLoaderConfiguration : ConfigurationBase<DataLoaderModel, DataLoaderView, DataLoaderController, DataLoaderConfiguration>
    {
        
    }
}
