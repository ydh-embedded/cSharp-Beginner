using System;
using System.Device.Gpio;
using System.Device.Adc;
using System.Device.Dac;

namespace cSharp;


//REVIEW - class Program
class Program
{
    static void Main(string[] args)
    {
            //SECTION - Create instances of ADC and DAC
            Adc adc = new Adc(); // Initialize ADC instance
            Dac dac = new Dac(); // Initialize DAC instance

            //SECTION - Create an instance of CurrentToVoltageConverter
            CurrentToVoltageConverter converter = new CurrentToVoltageConverter(adc, dac);

            //SECTION - Call the ConvertCurrentToVoltage method
            converter.ConvertCurrentToVoltage();
    }

}


//REVIEW - class CurrentToVoltageConverter
class CurrentToVoltageConverter
{
    private readonly Adc _adc;
    private readonly Dac _dac;



    public CurrentToVoltageConverter(Adc adc, Dac dac)
    {
        _adc = adc;
        _dac = dac;
    }


    public void ConvertCurrentToVoltage()
    {

        //SECTION - Read the current signal from the ADC
        int iCurrentValue = _adc.ReadValue();

    
        //SECTION - Convert the current value to a voltage value (0-5VDC)
        double dVoltageValue;
        // dVoltageValue = _dac.ReadValue();



     switch (iCurrentValue)
     {
        case 
            
            int value when value < 256:
            dVoltageValue = value * 5.0 / 256.0;
            break;

        case 
            
            int value when value < 512:
            dVoltageValue = (value - 256) * 5.0 / 512.0 + 1.25;
            break;

        case 
            
            int value when value < 768:
            dVoltageValue = (value - 512) * 5.0 / 768.0 + 2.5;
            break;

        
        default:

            dVoltageValue = 5.0;
            break;
     }

        //REWIEV - Output the voltage signal using the DAC
        _dac.WriteValue(dVoltageValue);

    }
}

