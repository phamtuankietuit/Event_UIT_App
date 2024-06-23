import React, { useState, useEffect } from 'react';
import { SafeAreaView } from "react-native-safe-area-context";
import { Text, View } from "react-native";
import { format } from 'date-fns';
function student_history() {
    return (
        <SafeAreaView className='mt-5'>
            <View className='flex justify-center items-center flex-col mt-3'>
                <Text className='text-xl'>Điểm rèn luyện</Text>
            </View>
            <View className='flex justify-center items-center flex-col mt-3'>
                <View className='border-dashed border-[3px] border-l-cyan-500 border-t-sky-500 border-r-blue-500 border-b-indigo-500 rounded-full h-[150px] w-[150px] flex justify-center items-center flex-col'>
                    <Text ><Text className='text-5xl font-bold'>100</Text> điểm</Text>
                </View>

            </View>
            <View className='px-3'>
                <Text className='ml-3 my-3'>Lịch sử cộng điểm :</Text>
                <View className='flex flex-row my-3'>
                    <Text>+</Text>
                    <Text className='ml-2'>Tham gia sự kiện seminar nghiên cứu khoa học câu lạc bộ lý luận UIT ({format(new Date(), 'dd MMM yyyy - HH:mm')}) : + 5 điểm</Text>
                </View>
                <View className='flex flex-row my-3'>
                    <Text>+</Text>
                    <Text className='ml-2'>Tham gia sự kiện seminar nghiên cứu khoa học câu lạc bộ lý luận UIT ({format(new Date(), 'dd MMM yyyy - HH:mm')}) : + 5 điểm</Text>
                </View>
                <View className='flex flex-row my-3'>
                    <Text>+</Text>
                    <Text className='ml-2'>Tham gia sự kiện seminar nghiên cứu khoa học câu lạc bộ lý luận UIT ({format(new Date(), 'dd MMM yyyy - HH:mm')}) : + 5 điểm</Text>
                </View>
                <View className='flex flex-row my-3'>
                    <Text>+</Text>
                    <Text className='ml-2'>Tham gia sự kiện seminar nghiên cứu khoa học câu lạc bộ lý luận UIT ({format(new Date(), 'dd MMM yyyy - HH:mm')}) : + 5 điểm</Text>
                </View>
            </View>
        </SafeAreaView>
    );
}

export default student_history;