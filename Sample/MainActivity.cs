using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ME.Itangqi.Waveloadingview;
using Android.Support.V7.App;
using Android.Graphics;
namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, RadioGroup.IOnCheckedChangeListener, CheckBox.IOnCheckedChangeListener, SeekBar.IOnSeekBarChangeListener
    {
        private WaveLoadingView mWaveLoadingView;
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
            // Set our view from the "main" layout resource

            mWaveLoadingView = FindViewById<WaveLoadingView>(Resource.Id.waveLoadingView);
            FindViewById<RadioGroup>(Resource.Id.rg_shape).SetOnCheckedChangeListener(this);
            FindViewById<CheckBox>(Resource.Id.cb_title_top).SetOnCheckedChangeListener(this);
            FindViewById<CheckBox>(Resource.Id.cb_title_center).SetOnCheckedChangeListener(this);
            FindViewById<CheckBox>(Resource.Id.cb_title_bottom).SetOnCheckedChangeListener(this);
            FindViewById<SeekBar>(Resource.Id.seekbar_progress).SetOnSeekBarChangeListener(this);
            FindViewById<SeekBar>(Resource.Id.seekbar_border_width).SetOnSeekBarChangeListener(this);
            FindViewById<SeekBar>(Resource.Id.seek_bar_amplitude).SetOnSeekBarChangeListener(this);
          

            FindViewById<Button>(Resource.Id.button1).Click += delegate
            {
                mWaveLoadingView.WaveColor = Color.Blue;
                mWaveLoadingView.BorderColor = Color.Blue;
            };
        }

        public void OnCheckedChanged(RadioGroup group, int checkedId)
        {
            switch (checkedId)
            {
                case Resource.Id.rb_shape_circle:
                    mWaveLoadingView.SetShapeType(WaveLoadingView.ShapeType.Circle);
                    break;
                case Resource.Id.rb_shape_square:
                    mWaveLoadingView.SetShapeType(WaveLoadingView.ShapeType.Square);
                    break;
                default:
                    break;
            }
        }

        public void OnCheckedChanged(CompoundButton buttonView, bool isChecked)
        {
            switch (buttonView.Id)
            {
                case Resource.Id.cb_title_top:
                    if (isChecked)
                    {
                        mWaveLoadingView.TopTitle = "Top Title";
                    }
                    else
                    {
                        mWaveLoadingView.TopTitle = "";
                    }
                    break;
                case Resource.Id.cb_title_center:
                    if (isChecked)
                    {
                        mWaveLoadingView.TopTitle = "Center Title";
                    }
                    else
                    {
                        mWaveLoadingView.TopTitle = "";
                    }
                    break;
                case Resource.Id.cb_title_bottom:
                    if (isChecked)
                    {
                        mWaveLoadingView.TopTitle = "Bottom Title";
                    }
                    else
                    {
                        mWaveLoadingView.TopTitle = "";
                    }
                    break;
                default:
                    break;
            }

        }

        public void OnProgressChanged(SeekBar seekBar, int progress, bool fromUser)
        {
            switch (seekBar.Id)
            {
                case Resource.Id.seekbar_progress:
                    mWaveLoadingView.ProgressValue = progress;
                    break;
                case Resource.Id.seekbar_border_width:
                    mWaveLoadingView.BorderWidth = progress;
                    break;
                case Resource.Id.seek_bar_amplitude:
                    mWaveLoadingView.SetAmplitudeRatio(progress);
                    break;
                default: break;
            }
            mWaveLoadingView.ProgressValue = progress;
        }

        public void OnStartTrackingTouch(SeekBar seekBar)
        {

        }

        public void OnStopTrackingTouch(SeekBar seekBar)
        {

        }
    }
}

