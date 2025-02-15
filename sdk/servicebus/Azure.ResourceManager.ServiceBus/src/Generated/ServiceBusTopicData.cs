// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing the ServiceBusTopic data model. </summary>
    public partial class ServiceBusTopicData : Resource
    {
        /// <summary> Initializes a new instance of ServiceBusTopicData. </summary>
        public ServiceBusTopicData()
        {
        }

        /// <summary> Initializes a new instance of ServiceBusTopicData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The system meta data relating to this resource. </param>
        /// <param name="sizeInBytes"> Size of the topic, in bytes. </param>
        /// <param name="createdAt"> Exact time the message was created. </param>
        /// <param name="updatedAt"> The exact time the message was updated. </param>
        /// <param name="accessedAt"> Last time the message was sent, or a request was received, for this topic. </param>
        /// <param name="subscriptionCount"> Number of subscriptions. </param>
        /// <param name="countDetails"> Message count details. </param>
        /// <param name="defaultMessageTimeToLive"> ISO 8601 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. </param>
        /// <param name="maxSizeInMegabytes"> Maximum size of the topic in megabytes, which is the size of the memory allocated for the topic. Default is 1024. </param>
        /// <param name="maxMessageSizeInKilobytes"> Maximum size (in KB) of the message payload that can be accepted by the topic. This property is only used in Premium today and default is 1024. </param>
        /// <param name="requiresDuplicateDetection"> Value indicating if this topic requires duplicate detection. </param>
        /// <param name="duplicateDetectionHistoryTimeWindow"> ISO8601 timespan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. </param>
        /// <param name="enableBatchedOperations"> Value that indicates whether server-side batched operations are enabled. </param>
        /// <param name="status"> Enumerates the possible values for the status of a messaging entity. </param>
        /// <param name="supportOrdering"> Value that indicates whether the topic supports ordering. </param>
        /// <param name="autoDeleteOnIdle"> ISO 8601 timespan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. </param>
        /// <param name="enablePartitioning"> Value that indicates whether the topic to be partitioned across multiple message brokers is enabled. </param>
        /// <param name="enableExpress"> Value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage. </param>
        internal ServiceBusTopicData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, long? sizeInBytes, DateTimeOffset? createdAt, DateTimeOffset? updatedAt, DateTimeOffset? accessedAt, int? subscriptionCount, MessageCountDetails countDetails, TimeSpan? defaultMessageTimeToLive, int? maxSizeInMegabytes, long? maxMessageSizeInKilobytes, bool? requiresDuplicateDetection, TimeSpan? duplicateDetectionHistoryTimeWindow, bool? enableBatchedOperations, EntityStatus? status, bool? supportOrdering, TimeSpan? autoDeleteOnIdle, bool? enablePartitioning, bool? enableExpress) : base(id, name, type)
        {
            SystemData = systemData;
            SizeInBytes = sizeInBytes;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            AccessedAt = accessedAt;
            SubscriptionCount = subscriptionCount;
            CountDetails = countDetails;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            MaxSizeInMegabytes = maxSizeInMegabytes;
            MaxMessageSizeInKilobytes = maxMessageSizeInKilobytes;
            RequiresDuplicateDetection = requiresDuplicateDetection;
            DuplicateDetectionHistoryTimeWindow = duplicateDetectionHistoryTimeWindow;
            EnableBatchedOperations = enableBatchedOperations;
            Status = status;
            SupportOrdering = supportOrdering;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            EnablePartitioning = enablePartitioning;
            EnableExpress = enableExpress;
        }

        /// <summary> The system meta data relating to this resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> Size of the topic, in bytes. </summary>
        public long? SizeInBytes { get; }
        /// <summary> Exact time the message was created. </summary>
        public DateTimeOffset? CreatedAt { get; }
        /// <summary> The exact time the message was updated. </summary>
        public DateTimeOffset? UpdatedAt { get; }
        /// <summary> Last time the message was sent, or a request was received, for this topic. </summary>
        public DateTimeOffset? AccessedAt { get; }
        /// <summary> Number of subscriptions. </summary>
        public int? SubscriptionCount { get; }
        /// <summary> Message count details. </summary>
        public MessageCountDetails CountDetails { get; }
        /// <summary> ISO 8601 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. </summary>
        public TimeSpan? DefaultMessageTimeToLive { get; set; }
        /// <summary> Maximum size of the topic in megabytes, which is the size of the memory allocated for the topic. Default is 1024. </summary>
        public int? MaxSizeInMegabytes { get; set; }
        /// <summary> Maximum size (in KB) of the message payload that can be accepted by the topic. This property is only used in Premium today and default is 1024. </summary>
        public long? MaxMessageSizeInKilobytes { get; set; }
        /// <summary> Value indicating if this topic requires duplicate detection. </summary>
        public bool? RequiresDuplicateDetection { get; set; }
        /// <summary> ISO8601 timespan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. </summary>
        public TimeSpan? DuplicateDetectionHistoryTimeWindow { get; set; }
        /// <summary> Value that indicates whether server-side batched operations are enabled. </summary>
        public bool? EnableBatchedOperations { get; set; }
        /// <summary> Enumerates the possible values for the status of a messaging entity. </summary>
        public EntityStatus? Status { get; set; }
        /// <summary> Value that indicates whether the topic supports ordering. </summary>
        public bool? SupportOrdering { get; set; }
        /// <summary> ISO 8601 timespan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. </summary>
        public TimeSpan? AutoDeleteOnIdle { get; set; }
        /// <summary> Value that indicates whether the topic to be partitioned across multiple message brokers is enabled. </summary>
        public bool? EnablePartitioning { get; set; }
        /// <summary> Value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage. </summary>
        public bool? EnableExpress { get; set; }
    }
}
