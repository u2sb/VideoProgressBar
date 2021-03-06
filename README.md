# VideoProgressBar

## 介绍

一个可以自动生成视频进度条的跨平台工具

![示意图.png](https://z3.ax1x.com/2021/10/28/5OD238.png)

## 使用说明

### 依赖

本工具运行需 [.net 5.0](https://dotnet.microsoft.com/download/dotnet/5.0/runtime)，如不想安装请选择带有运行环境的版本(scd)。

### GUI 工具

开发中...

### CLI 工具

运行平台

- [x] Windows
- [x] Linux
- [x] OSX


编辑 `Config` 下的配置文件

#### 尺寸

编辑 `size.json`, Bg 下分别为背景宽度，背景高度，进度条高度，Vn 下分别为分割线宽度，字体大小

#### 字体

讲需要更换的字体放入 `Fonts` 目录下，编辑 `font.json`

#### 颜色

编辑 `color.json`，Bg 为背景相关，Pb 为前景相关，Tc 为进度条分割线和字体相关，颜色格式为 Rgba32，可在网上找相关工具辅助取色

#### 节点

编辑 `video.json`，格式为 "开始时间": "节点名称"，注意，开始时间取值为 `0 - 1`，需按比例计算。

配置文件编辑完成后，运行工具即可。

## 说明

### 字体

部分发布版本含有字体

- 极影毁片圆 (SILOpenFontLicense1.1)