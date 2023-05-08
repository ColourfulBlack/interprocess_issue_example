using Cloudtoid.Interprocess;
using Microsoft.Extensions.Logging;

var factory = new QueueFactory();
var options = new QueueOptions(
    queueName: "sample-queue", bytesCapacity: 24);
using var publisher = factory.CreatePublisher(options);
