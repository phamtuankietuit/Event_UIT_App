import React, { useState, useEffect } from 'react';
import { Text, View, Dimensions } from "react-native";
import { PieChart } from 'react-native-chart-kit';
function report_page() {
    const data = [
        {
            name: 'Seoul',
            population: 21500000,
            color: '#4682B4',
            legendFontColor: '#7F7F7F',
            legendFontSize: 15,
        },
        {
            name: 'Toronto',
            population: 2800000,
            color: '#FF6347',
            legendFontColor: '#7F7F7F',
            legendFontSize: 15,
        },

    ];

    const screenWidth = Dimensions.get('window').width;

    return (
        <View className='mt-1 flex-1 px-3 '>
            <View className='my-3 mb-6 flex flex-col items-center justify-center bg-white py-2 rounded-lg'>
                <Text className='text-xl font-semibold text-sky-600 '>
                    Báo cáo
                </Text>
            </View>
            <View className='border-stone-200 mb-4 shadow-lg shadow-black rounded-lg bg-white'>
                <View className='mt-5 flex flex-col items-center justify-center'>
                    <Text className=''>
                        Tỷ lệ người đăng ký sự kiện
                    </Text>
                </View>
                <PieChart
                    data={data}
                    width={screenWidth}
                    height={220}
                    valueAccessor={({ item }) => item.population}
                    chartConfig={{
                        backgroundColor: '#1cc910',
                        backgroundGradientFrom: '#eff3ff',
                        backgroundGradientTo: '#efefef',
                        decimalPlaces: 2,
                        color: (opacity = 1) => `rgba(0, 0, 0, ${opacity})`,
                        style: {
                            borderRadius: 16,
                        },
                    }}
                    accessor="population"
                    backgroundColor="transparent"
                    paddingLeft="10"
                >
                </PieChart>
            </View>

            <View className='border-stone-200 mb-4 shadow-lg shadow-black rounded-lg bg-white'>
                <View className='mt-5 flex flex-col items-center justify-center'>
                    <Text className=''>
                        Tỷ lệ người tham gia sự kiện
                    </Text>
                </View>
                <PieChart
                    data={data}
                    width={screenWidth}
                    height={220}
                    valueAccessor={({ item }) => item.population}
                    chartConfig={{
                        backgroundColor: '#1cc910',
                        backgroundGradientFrom: '#eff3ff',
                        backgroundGradientTo: '#efefef',
                        decimalPlaces: 2,
                        color: (opacity = 1) => `rgba(0, 0, 0, ${opacity})`,
                        style: {
                            borderRadius: 16,
                        },
                    }}
                    accessor="population"
                    backgroundColor="transparent"
                    paddingLeft="10"
                >
                </PieChart>
            </View>

        </View>
    );
}

export default report_page;