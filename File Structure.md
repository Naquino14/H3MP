### A File tree of important documents and scripts

\---src
    |   manifest.json
    |   
    +---H3MP
    |   +---Configs
    |   |       ClientConfig.cs
    |   |       ClientPuppetConfig.cs
    |   |       ClientPuppetLimbColorConfig.cs
    |   |       ClientPuppetLimbConfig.cs
    |   |       HostBindingConfig.cs
    |   |       HostConfig.cs
    |   |       HostPermissionConfig.cs
    |   |       HostPublicBindingConfig.cs
    |   |       RootConfig.cs
    |   |       
    |   +---Discord | Theres a good chance some of these scripts arent used by the mod itself, and are rather just templates, the supposedly unused ones will have a * next to it
    |   |       ActivityManager.cs | this is being used in the mod, but im not sure for what...
    |   |       Constants.cs | stores the discord game sdk dll name
    |   |       Core.cs | main discord invite controller
    |   |       discord_game_sdk.dll | discord sdk dll
    |   |       ImageManager.cs | gets the discord user's image
    |   |       LobbyManager.cs | (guess) looks therough the connected members of a server and grabs their info
    |   |       README.md | Readme info on everything in this folder
    |   |       StorageManager.cs*
    |   |       StoreManager.cs*
    |   |       
    |   +---Enums
    |   |       JoinError.cs
    |   |       
    |   +---Extensions
    |   |       DateTimeExtensions.cs
    |   |       NetDataReaderExtensions.cs
    |   |       NetDataWriterExtensions.cs
    |   |       
    |   +---HarmonyPatches
    |   |       HarmonyState.cs
    |   |       LoadLevelPatch.cs
    |   |       SetLinkAccessoryPatch.cs
    |   |       WristMenuResetConfirmPatch.cs
    |   |       
    |   +---Messages
    |   |       ConnectionRequestMessage.cs
    |   |       InitMessage.cs
    |   |       LevelChangeMessage.cs
    |   |       PingMessage.cs
    |   |       PlayerJoinMessage.cs
    |   |       PlayerLeaveMessage.cs
    |   |       PlayerMovesMessage.cs
    |   |       PlayerTransformsMessage.cs
    |   |       TimestampedMessage.cs
    |   |       TransformMessage.cs
    |   |       
    |   +---Models
    |   |       DoubleRange.cs
    |   |       HealthInfo.cs
    |   |       JoinSecret.cs
    |   |       Key32.cs
    |   |       ServerTime.cs
    |   |       
    |   |   \---Debug
    |   |       |   DesignTimeResolveAssemblyReferencesInput.cache
    |   |       |   H3MP.csproj.CopyComplete
    |   |       |   H3MP.csproj.CoreCompileInputs.cache
    |   |       |   H3MP.csproj.FileListAbsolute.txt
    |   |       |   H3MP.csprojAssemblyReference.cache
    |   |       |   H3MP.dll
    |   |       |   H3MP.pdb
    |   |
    |   +---Peers
    |   |       H3Client.cs
    |   |       H3Server.cs
    |   |       Husk.cs
    |   |       Puppet.cs
    |   |       
    |   +---Properties
    |   |       AssemblyInfo.cs
    |   |       
    |   \---Utils
    |       |   Fitting.cs
    |       |   ILinearFittable.cs
    |       |   IRenderUpdatable.cs
    |       |   LocalTime.cs
    |       |   MoreMath.cs
    |       |   PrivacyManager.cs
    |       |   WristMenuButtons.cs
    |       |   
    |       +---MovingAverages
    |       |       ExponentialMovingAverage.cs
    |       |       IMovingAverage.cs
    |       |       SimpleMovingAverage.cs
    |       |       
    |       +---Snapshots
    |       |       CountSnapshotKiller.cs
    |       |       ISnapshotKiller.cs
    |       |       Snapshots.cs
    |       |       TimeSnapshotKiller.cs
    |       |       
    |       \---Timers
    |               LoopCounter.cs
    |               LoopTimer.cs
    |               
    \---H3MP.Networking
        |           
        +---Extensions
        |       NetDataReaderExtensions.cs
        |       NetDataWriterExtensions.cs
        |       VersionExtensions.cs
        |       
        +---Listeners
        |       ClientListenerEvents.cs
        |       IListenerEvents.cs
        |       MessageListener.cs
        |       ServerListenerEvents.cs
        |       
        +---Messages
        |       MessageDefinition.cs
        |       PeerMessageList.cs
        |       UniversalMessageList.cs
        |       
        +---Models
        |       ConnectionError.cs
        |       MismatchedVersionErrorMessage.cs
        |       
        +---obj
        |   |   H3MP.Networking.csproj.nuget.dgspec.json
        |   |   H3MP.Networking.csproj.nuget.g.props
        |   |   H3MP.Networking.csproj.nuget.g.targets
        |   |   project.assets.json
        |   |   project.nuget.cache
        |   |    
        +---Peers
        |       Client.cs
        |       Peer.cs
        |       SelfPeer.cs
        |       Server.cs
        |       
        +---Properties
        |       AssemblyInfo.cs
        |       
        +---Services
        |       IClientEvents.cs
        |       IServerEvents.cs
        |       IUpdatable.cs
        |       
        \---Utils
                IPoolSource.cs
                NetDataWriterPoolSource.cs
                Pool.cs
                WriterPool.cs
