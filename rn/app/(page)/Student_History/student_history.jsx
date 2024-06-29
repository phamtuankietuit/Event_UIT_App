import React, { useState, useEffect } from 'react';
import { SafeAreaView } from "react-native-safe-area-context";
import { Text, View } from "react-native";
import { format } from 'date-fns';
import * as StudentServices from '../../apiServices/studentServices'
function student_history() {
    const [trainingPointHistories, setTrainingPointHistories] = useState([])
    useEffect(() => {
        const fectch = async () => {
            const response = await StudentServices.getTrainingPointHistory()
                .catch((error) => {
                    // xử lý lỗi
                    if (error.response) {
                        if (error.response.status === 401) {
                            showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
                        } else if (error.response.status === 403) {
                            showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
                        }
                    } else {
                        showToastWithGravity("Có lỗi xảy ra")
                    }
                })

            if (response) {
                // Xử lý nếu response trả về
                setTrainingPointHistories(response.trainingPointHistories)
            }
        }

        fectch()
    }, [])
    return (
        <View className='mt-1'>
            <View className='flex justify-center items-center flex-col mt-3'>
                <Text className='text-xl text-sky-600 font-semibold'>Điểm rèn luyện</Text>
            </View>
            <View className='flex justify-center items-center flex-col mt-3'>
                <View className='border-dashed border-[3px] border-l-cyan-500 border-t-sky-500 border-r-blue-500 border-b-indigo-500 rounded-full h-[150px] w-[150px] flex justify-center items-center flex-col'>
                    <Text ><Text className='text-5xl font-bold'>100</Text> điểm</Text>
                </View>

            </View>
            <View className='px-3'>
                <Text className='ml-3 my-3'>Lịch sử cộng điểm :</Text>
                {
                    trainingPointHistories.map((item, index) => (
                        <View className='flex flex-row my-3' key={index}
                        >
                            <Text>+</Text>
                            <Text className='ml-2'>Tham gia sự kiện {item.eventName} ({format(item.attendDate, 'dd MM yyyy - HH:mm')}) : + {item.trainingPoint} điểm</Text>
                        </View>
                    ))
                }

            </View>
        </View>
    );
}

export default student_history;