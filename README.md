# Robotic Arm Control Panel Core

[![GitHub release](https://img.shields.io/github/release/nfu-irs-lab/robotic-arm-control-panel-core.svg)](https://github.com/nfu-irs-lab/robotic-arm-control-panel-core/releases)
[![GitHub issues](https://img.shields.io/github/issues/nfu-irs-lab/robotic-arm-control-panel-core.svg)](https://github.com/nfu-irs-lab/robotic-arm-control-panel-core/issues)

手臂控制面板核心功能 C# Project。

## 整體架構
- [MainForm](MainForm.cs)：視窗的基本物件。
- [Contest](Contest.cs)：各比賽關卡或用途的專屬程式。
- [Config](Config.cs)：可調整之設定參數。
- [ActionFlow](ActionFlow.cs)：動作流程。
- [Arm](Arm.cs)：手臂。
- ~~[Camera](Camera.cs)：相機。~~
- [Connection](Connection.cs)：連線與斷線。
- [Gripper](Gripper.cs)：夾爪。
- [Jog](Jog.cs)：吋動。
- [Keyboard](Keyboard.cs)：鍵盤按鍵事件。
- [PositionRecord](PositionRecord.cs)：位置記錄。
