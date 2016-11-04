//-----------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// 
//  The MIT License (MIT)
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//  ---------------------------------------------------------------------------------

using System.Web.Configuration;

namespace PhotoSharingApp.AppService.Shared.Context
{
    /// <summary>
    /// The service environment definition.
    /// </summary>
    public class EnvironmentDefinition : EnvironmentDefinitionBase
    {
        private DocumentDbStorage _documentDbStorage;

        /// <summary>
        /// The DocumentDB database.
        /// </summary>
        public override DocumentDbStorage DocumentDbStorage
        {
            get
            {
                if (_documentDbStorage == null)
                {
                    _documentDbStorage = new DocumentDbStorage
                    {
                        // We have supplied a default DatabaseId and CollectionId here, feel free to configure your own.
                        // On first time startup, the service will create a DocumentDB database and collection for you
                        // if none exist with these names.
                        DataBaseId = "photosharing-database",
                        CollectionId = "photosharing-document-data",
                        EndpointUrl = "https://photosharingappdemo.documents.azure.com:443/",
                        AuthorizationKey = "Ya2FeT98F8FQUsJmQYKAKSn4NgQNsMsqUklkAvZOspDtZfRC0Tu6gBkpHU4pqKcQURya14CQ7aVuzvxhxYf04Q=="
                    };
                }

                return _documentDbStorage;
            }
        }

        /// <summary>
        /// The Notification Hub's default full shared access signature.
        /// </summary>
        public override string HubFullSharedAccessSignature
        {
            get
            {
                return "Endpoint=sb://photosampleapp.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=wZcNdcKgy/YKmjCst3bX53a/gbBMs5hYNkwzHM8zx2Q=";
            }
        }

        /// <summary>
        /// The Notification Hub's name.
        /// </summary>
        public override string HubName
        {
            get { return "PhotoSampleAppDemo"; }
        }

        /// <summary>
        /// The Application Insights instrumentation key. This value is read from the Web.config file.
        /// </summary>
        public override string InstrumentationKey
        {
            get { return "eb6a0330-6df6-4d7f-a7a7-a25d4ee79e5c"; }
        }

        /// <summary>
        /// The Azure Storage access key that is used for storing
        /// uploaded photos.
        /// </summary>
        public override string StorageAccessKey
        {
            get { return "x7TluHcxfLJFzLxj8MoqESVtUTloH8lym2MR342nnTJniWbVnK4HWSq+SIEvXeVHfoZATaQKiTu9WTSSMEAc5A=="; }
        }

        /// <summary>
        /// The Azure Storage account name that is used for storing
        /// uploaded photos.
        /// </summary>
        public override string StorageAccountName
        {
            get { return "photosharingappdemo"; }
        }
    }
}