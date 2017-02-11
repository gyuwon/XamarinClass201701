# Xamarin 강의 자료(2017-02)

2017년 2월 8~9일 스킬서포트 Xamarin 강의 수강자를 위한 저장소입니다.

## 슬라이드

강의에 사용된 슬라이드는 [여기](./documents)에서 다운로드하실 수 있습니다.

## 소스코드

강의에 사용된 모든 소스코드는 [여기](./source)의 DemoApps.sln 솔루션에 들어있습니다.

## 문제 해결

강의 실습 중 발생한 안드로이드 에뮬레이터에서 앱이 즉시 크래시되는 현상은 [여기](https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/debug-on-emulator/visual-studio-android-emulator/#Emulator_will_not_start)에 해결방법이 설명되어 있습니다.

1. Click the Start button, type in MMC, and press Enter. Click Hyper-V Manager as illustrated here:
<br />![](https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/debug-on-emulator/visual-studio-android-emulator/Images/15-launch-hyperv-manager.png)
1. In the Hyper-V Manager Virtual Machines pane, right click the emulator that to edit to use and click Settings...":
<br />![](https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/debug-on-emulator/visual-studio-android-emulator/Images/16-vm-settings.png)
1. In the settings window, locate the Compatibility section (under Hardware > Processor) and enable Migrate to a physical computer with a different processor version:
<br />![](https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/debug-on-emulator/visual-studio-android-emulator/Images/17-set-compatibility-vs.png)
1. Click OK and close the Hyper-V Manager window.

## 기타 요청

누락된 자료나 추가 요청사항은 [여기](https://github.com/gyuwon/XamarinClass201701/issues?utf8=%E2%9C%93&q=)에서 요청하거나 확인하세요.
