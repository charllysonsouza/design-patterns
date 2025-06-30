using Adapter.Adapters;
using Adapter.Devices;

Computer pc = new Computer();
OldMonitor monitor = new OldMonitor();

pc.Connect(new HdmiToVgaAdapter(monitor));
pc.SendImageAndSound("Cat and rainbow", "Nyan cat song");